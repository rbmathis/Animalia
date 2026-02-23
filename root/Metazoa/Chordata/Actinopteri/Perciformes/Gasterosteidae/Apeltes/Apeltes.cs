using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Gasterosteidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Gasterosteidae.Apeltes;

/// <summary>
/// Abstract class for Apeltes (genus).
/// NCBI TaxId: 240153
/// </summary>
public abstract class Apeltes : Gasterosteidae, IApeltes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Apeltes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 240153;

    /// <inheritdoc />
    public virtual string GenusName => "Apeltes";

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
