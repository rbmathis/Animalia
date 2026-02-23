using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Chalcophaps;

/// <summary>
/// Abstract class for Chalcophaps (genus).
/// NCBI TaxId: 187107
/// </summary>
public abstract class Chalcophaps : Columbidae, IChalcophaps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chalcophaps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 187107;

    /// <inheritdoc />
    public virtual string GenusName => "Chalcophaps";

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
