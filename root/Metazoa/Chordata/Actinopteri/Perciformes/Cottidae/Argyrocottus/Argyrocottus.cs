using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Argyrocottus;

/// <summary>
/// Abstract class for Argyrocottus (genus).
/// NCBI TaxId: 1633510
/// </summary>
public abstract class Argyrocottus : Cottidae, IArgyrocottus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Argyrocottus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1633510;

    /// <inheritdoc />
    public virtual string GenusName => "Argyrocottus";

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
