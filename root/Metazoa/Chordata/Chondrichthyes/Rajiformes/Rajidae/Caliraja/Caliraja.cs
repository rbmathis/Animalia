using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae.Caliraja;

/// <summary>
/// Abstract class for Caliraja (genus).
/// NCBI TaxId: 3363395
/// </summary>
public abstract class Caliraja : Rajidae, ICaliraja
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Caliraja";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3363395;

    /// <inheritdoc />
    public virtual string GenusName => "Caliraja";

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
