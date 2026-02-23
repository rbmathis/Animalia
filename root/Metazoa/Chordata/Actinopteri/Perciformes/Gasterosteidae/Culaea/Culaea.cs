using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Gasterosteidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Gasterosteidae.Culaea;

/// <summary>
/// Abstract class for Culaea (genus).
/// NCBI TaxId: 240155
/// </summary>
public abstract class Culaea : Gasterosteidae, ICulaea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Culaea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 240155;

    /// <inheritdoc />
    public virtual string GenusName => "Culaea";

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
