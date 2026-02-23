using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Priacanthiformes.Priacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Priacanthiformes.Priacanthidae.Pristigenys;

/// <summary>
/// Abstract class for Pristigenys (genus).
/// NCBI TaxId: 184446
/// </summary>
public abstract class Pristigenys : Priacanthidae, IPristigenys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pristigenys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 184446;

    /// <inheritdoc />
    public virtual string GenusName => "Pristigenys";

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
