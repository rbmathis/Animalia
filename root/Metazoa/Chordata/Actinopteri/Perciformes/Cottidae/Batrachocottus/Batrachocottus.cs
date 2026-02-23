using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Batrachocottus;

/// <summary>
/// Abstract class for Batrachocottus (genus).
/// NCBI TaxId: 37345
/// </summary>
public abstract class Batrachocottus : Cottidae, IBatrachocottus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Batrachocottus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 37345;

    /// <inheritdoc />
    public virtual string GenusName => "Batrachocottus";

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
