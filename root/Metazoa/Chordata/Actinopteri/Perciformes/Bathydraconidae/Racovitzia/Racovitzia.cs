using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bathydraconidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bathydraconidae.Racovitzia;

/// <summary>
/// Abstract class for Racovitzia (genus).
/// NCBI TaxId: 202072
/// </summary>
public abstract class Racovitzia : Bathydraconidae, IRacovitzia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Racovitzia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 202072;

    /// <inheritdoc />
    public virtual string GenusName => "Racovitzia";

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
