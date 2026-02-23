using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Limnocottus;

/// <summary>
/// Abstract class for Limnocottus (genus).
/// NCBI TaxId: 61632
/// </summary>
public abstract class Limnocottus : Cottidae, ILimnocottus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Limnocottus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 61632;

    /// <inheritdoc />
    public virtual string GenusName => "Limnocottus";

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
