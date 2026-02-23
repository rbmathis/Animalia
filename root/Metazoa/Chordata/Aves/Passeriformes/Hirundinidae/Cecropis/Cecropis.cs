using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Hirundinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Hirundinidae.Cecropis;

/// <summary>
/// Abstract class for Cecropis (genus).
/// NCBI TaxId: 69504
/// </summary>
public abstract class Cecropis : Hirundinidae, ICecropis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cecropis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 69504;

    /// <inheritdoc />
    public virtual string GenusName => "Cecropis";

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
