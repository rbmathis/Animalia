using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Porocottus;

/// <summary>
/// Abstract class for Porocottus (genus).
/// NCBI TaxId: 1526733
/// </summary>
public abstract class Porocottus : Cottidae, IPorocottus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Porocottus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1526733;

    /// <inheritdoc />
    public virtual string GenusName => "Porocottus";

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
