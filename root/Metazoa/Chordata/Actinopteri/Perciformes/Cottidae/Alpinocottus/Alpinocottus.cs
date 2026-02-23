using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Alpinocottus;

/// <summary>
/// Abstract class for Alpinocottus (genus).
/// NCBI TaxId: 3363381
/// </summary>
public abstract class Alpinocottus : Cottidae, IAlpinocottus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alpinocottus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3363381;

    /// <inheritdoc />
    public virtual string GenusName => "Alpinocottus";

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
