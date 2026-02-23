using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Oblada;

/// <summary>
/// Abstract class for Oblada (genus).
/// NCBI TaxId: 98824
/// </summary>
public abstract class Oblada : Sparidae, IOblada
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oblada";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 98824;

    /// <inheritdoc />
    public virtual string GenusName => "Oblada";

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
