using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Nesotriccus;

/// <summary>
/// Abstract class for Nesotriccus (genus).
/// NCBI TaxId: 2767942
/// </summary>
public abstract class Nesotriccus : Tyrannidae, INesotriccus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nesotriccus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2767942;

    /// <inheritdoc />
    public virtual string GenusName => "Nesotriccus";

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
