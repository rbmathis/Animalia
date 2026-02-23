using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae.Eminia;

/// <summary>
/// Abstract class for Eminia (genus).
/// NCBI TaxId: 98124
/// </summary>
public abstract class Eminia : Cisticolidae, IEminia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eminia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 98124;

    /// <inheritdoc />
    public virtual string GenusName => "Eminia";

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
