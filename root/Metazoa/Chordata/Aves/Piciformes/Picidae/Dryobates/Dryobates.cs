using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Dryobates;

/// <summary>
/// Abstract class for Dryobates (genus).
/// NCBI TaxId: 1517830
/// </summary>
public abstract class Dryobates : Picidae, IDryobates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dryobates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1517830;

    /// <inheritdoc />
    public virtual string GenusName => "Dryobates";

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
