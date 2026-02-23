using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Creediidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Creediidae.Crystallodytes;

/// <summary>
/// Abstract class for Crystallodytes (genus).
/// NCBI TaxId: 2589275
/// </summary>
public abstract class Crystallodytes : Creediidae, ICrystallodytes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crystallodytes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2589275;

    /// <inheritdoc />
    public virtual string GenusName => "Crystallodytes";

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
