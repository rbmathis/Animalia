using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Lathrotriccus;

/// <summary>
/// Abstract class for Lathrotriccus (genus).
/// NCBI TaxId: 183536
/// </summary>
public abstract class Lathrotriccus : Tyrannidae, ILathrotriccus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lathrotriccus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 183536;

    /// <inheritdoc />
    public virtual string GenusName => "Lathrotriccus";

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
