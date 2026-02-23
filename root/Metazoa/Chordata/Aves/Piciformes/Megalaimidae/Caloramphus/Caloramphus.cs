using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Megalaimidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Megalaimidae.Caloramphus;

/// <summary>
/// Abstract class for Caloramphus (genus).
/// NCBI TaxId: 240711
/// </summary>
public abstract class Caloramphus : Megalaimidae, ICaloramphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Caloramphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 240711;

    /// <inheritdoc />
    public virtual string GenusName => "Caloramphus";

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
