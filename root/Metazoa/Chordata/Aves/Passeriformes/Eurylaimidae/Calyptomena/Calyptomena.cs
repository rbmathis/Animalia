using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Eurylaimidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Eurylaimidae.Calyptomena;

/// <summary>
/// Abstract class for Calyptomena (genus).
/// NCBI TaxId: 135971
/// </summary>
public abstract class Calyptomena : Eurylaimidae, ICalyptomena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Calyptomena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 135971;

    /// <inheritdoc />
    public virtual string GenusName => "Calyptomena";

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
