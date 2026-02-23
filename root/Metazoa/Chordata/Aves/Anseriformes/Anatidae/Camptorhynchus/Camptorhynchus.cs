using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Camptorhynchus;

/// <summary>
/// Abstract class for Camptorhynchus (genus).
/// NCBI TaxId: 399385
/// </summary>
public abstract class Camptorhynchus : Anatidae, ICamptorhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Camptorhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 399385;

    /// <inheritdoc />
    public virtual string GenusName => "Camptorhynchus";

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
