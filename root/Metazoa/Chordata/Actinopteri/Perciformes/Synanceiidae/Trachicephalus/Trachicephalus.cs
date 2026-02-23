using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Synanceiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Synanceiidae.Trachicephalus;

/// <summary>
/// Abstract class for Trachicephalus (genus).
/// NCBI TaxId: 2047809
/// </summary>
public abstract class Trachicephalus : Synanceiidae, ITrachicephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trachicephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2047809;

    /// <inheritdoc />
    public virtual string GenusName => "Trachicephalus";

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
