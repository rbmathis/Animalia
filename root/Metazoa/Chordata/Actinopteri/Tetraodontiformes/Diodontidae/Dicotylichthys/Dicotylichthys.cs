using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Diodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Diodontidae.Dicotylichthys;

/// <summary>
/// Abstract class for Dicotylichthys (genus).
/// NCBI TaxId: 1311541
/// </summary>
public abstract class Dicotylichthys : Diodontidae, IDicotylichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dicotylichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1311541;

    /// <inheritdoc />
    public virtual string GenusName => "Dicotylichthys";

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
