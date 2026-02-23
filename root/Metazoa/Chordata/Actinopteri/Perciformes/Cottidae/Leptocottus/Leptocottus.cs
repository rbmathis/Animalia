using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Leptocottus;

/// <summary>
/// Abstract class for Leptocottus (genus).
/// NCBI TaxId: 214924
/// </summary>
public abstract class Leptocottus : Cottidae, ILeptocottus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptocottus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 214924;

    /// <inheritdoc />
    public virtual string GenusName => "Leptocottus";

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
