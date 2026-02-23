using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Opostomias;

/// <summary>
/// Abstract class for Opostomias (genus).
/// NCBI TaxId: 1604630
/// </summary>
public abstract class Opostomias : Stomiidae, IOpostomias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Opostomias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1604630;

    /// <inheritdoc />
    public virtual string GenusName => "Opostomias";

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
