using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae.Grahamina;

/// <summary>
/// Abstract class for Grahamina (genus).
/// NCBI TaxId: 582519
/// </summary>
public abstract class Grahamina : Tripterygiidae, IGrahamina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Grahamina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 582519;

    /// <inheritdoc />
    public virtual string GenusName => "Grahamina";

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
