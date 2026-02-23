using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae.Prinia;

/// <summary>
/// Abstract class for Prinia (genus).
/// NCBI TaxId: 81891
/// </summary>
public abstract class Prinia : Cisticolidae, IPrinia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Prinia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 81891;

    /// <inheritdoc />
    public virtual string GenusName => "Prinia";

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
