using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Paracottus;

/// <summary>
/// Abstract class for Paracottus (genus).
/// NCBI TaxId: 61625
/// </summary>
public abstract class Paracottus : Cottidae, IParacottus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paracottus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 61625;

    /// <inheritdoc />
    public virtual string GenusName => "Paracottus";

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
