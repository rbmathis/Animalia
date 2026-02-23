using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae.Euryptila;

/// <summary>
/// Abstract class for Euryptila (genus).
/// NCBI TaxId: 315543
/// </summary>
public abstract class Euryptila : Cisticolidae, IEuryptila
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Euryptila";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 315543;

    /// <inheritdoc />
    public virtual string GenusName => "Euryptila";

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
