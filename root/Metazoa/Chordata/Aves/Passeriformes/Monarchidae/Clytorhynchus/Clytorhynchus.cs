using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Monarchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Monarchidae.Clytorhynchus;

/// <summary>
/// Abstract class for Clytorhynchus (genus).
/// NCBI TaxId: 338448
/// </summary>
public abstract class Clytorhynchus : Monarchidae, IClytorhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Clytorhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 338448;

    /// <inheritdoc />
    public virtual string GenusName => "Clytorhynchus";

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
