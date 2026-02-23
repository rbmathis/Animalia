using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae.Apalis;

/// <summary>
/// Abstract class for Apalis (genus).
/// NCBI TaxId: 208066
/// </summary>
public abstract class Apalis : Cisticolidae, IApalis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Apalis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 208066;

    /// <inheritdoc />
    public virtual string GenusName => "Apalis";

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
