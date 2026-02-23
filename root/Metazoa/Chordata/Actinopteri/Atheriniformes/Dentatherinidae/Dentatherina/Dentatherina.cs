using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Dentatherinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Dentatherinidae.Dentatherina;

/// <summary>
/// Abstract class for Dentatherina (genus).
/// NCBI TaxId: 1489916
/// </summary>
public abstract class Dentatherina : Dentatherinidae, IDentatherina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dentatherina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1489916;

    /// <inheritdoc />
    public virtual string GenusName => "Dentatherina";

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
