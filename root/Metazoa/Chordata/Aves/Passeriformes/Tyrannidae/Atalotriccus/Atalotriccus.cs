using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Atalotriccus;

/// <summary>
/// Abstract class for Atalotriccus (genus).
/// NCBI TaxId: 360209
/// </summary>
public abstract class Atalotriccus : Tyrannidae, IAtalotriccus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Atalotriccus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 360209;

    /// <inheritdoc />
    public virtual string GenusName => "Atalotriccus";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
