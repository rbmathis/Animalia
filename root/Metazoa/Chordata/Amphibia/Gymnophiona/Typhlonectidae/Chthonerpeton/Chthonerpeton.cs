using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Typhlonectidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Typhlonectidae.Chthonerpeton;

/// <summary>
/// Abstract class for Chthonerpeton (genus).
/// NCBI TaxId: 264002
/// </summary>
public abstract class Chthonerpeton : Typhlonectidae, IChthonerpeton
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chthonerpeton";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 264002;

    /// <inheritdoc />
    public virtual string GenusName => "Chthonerpeton";

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
