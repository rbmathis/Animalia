using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae.Cisticola;

/// <summary>
/// Abstract class for Cisticola (genus).
/// NCBI TaxId: 52621
/// </summary>
public abstract class Cisticola : Cisticolidae, ICisticola
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cisticola";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52621;

    /// <inheritdoc />
    public virtual string GenusName => "Cisticola";

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
