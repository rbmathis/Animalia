using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae.Urolais;

/// <summary>
/// Abstract class for Urolais (genus).
/// NCBI TaxId: 483070
/// </summary>
public abstract class Urolais : Cisticolidae, IUrolais
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Urolais";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 483070;

    /// <inheritdoc />
    public virtual string GenusName => "Urolais";

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
