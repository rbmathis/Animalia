using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Leiocottus;

/// <summary>
/// Abstract class for Leiocottus (genus).
/// NCBI TaxId: 459048
/// </summary>
public abstract class Leiocottus : Cottidae, ILeiocottus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leiocottus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 459048;

    /// <inheritdoc />
    public virtual string GenusName => "Leiocottus";

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
