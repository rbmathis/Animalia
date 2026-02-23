using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Rhinatrematidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Rhinatrematidae.Amazops;

/// <summary>
/// Abstract class for Amazops (genus).
/// NCBI TaxId: 3373010
/// </summary>
public abstract class Amazops : Rhinatrematidae, IAmazops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amazops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3373010;

    /// <inheritdoc />
    public virtual string GenusName => "Amazops";

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
