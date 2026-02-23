using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Chelonodontops;

/// <summary>
/// Abstract class for Chelonodontops (genus).
/// NCBI TaxId: 2358450
/// </summary>
public abstract class Chelonodontops : Tetraodontidae, IChelonodontops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chelonodontops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2358450;

    /// <inheritdoc />
    public virtual string GenusName => "Chelonodontops";

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
