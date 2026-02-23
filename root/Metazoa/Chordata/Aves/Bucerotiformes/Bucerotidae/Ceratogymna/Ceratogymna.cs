using AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Bucerotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Bucerotidae.Ceratogymna;

/// <summary>
/// Abstract class for Ceratogymna (genus).
/// NCBI TaxId: 175831
/// </summary>
public abstract class Ceratogymna : Bucerotidae, ICeratogymna
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ceratogymna";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 175831;

    /// <inheritdoc />
    public virtual string GenusName => "Ceratogymna";

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
