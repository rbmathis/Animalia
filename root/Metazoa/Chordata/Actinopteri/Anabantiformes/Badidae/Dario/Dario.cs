using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Badidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Badidae.Dario;

/// <summary>
/// Abstract class for Dario (genus).
/// NCBI TaxId: 248992
/// </summary>
public abstract class Dario : Badidae, IDario
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dario";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 248992;

    /// <inheritdoc />
    public virtual string GenusName => "Dario";

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
