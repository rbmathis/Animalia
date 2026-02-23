using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Anabantidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Anabantidae.Anabas;

/// <summary>
/// Abstract class for Anabas (genus).
/// NCBI TaxId: 64143
/// </summary>
public abstract class Anabas : Anabantidae, IAnabas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anabas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 64143;

    /// <inheritdoc />
    public virtual string GenusName => "Anabas";

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
