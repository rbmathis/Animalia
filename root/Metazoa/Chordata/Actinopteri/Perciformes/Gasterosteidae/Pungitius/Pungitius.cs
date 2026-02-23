using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Gasterosteidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Gasterosteidae.Pungitius;

/// <summary>
/// Abstract class for Pungitius (genus).
/// NCBI TaxId: 134919
/// </summary>
public abstract class Pungitius : Gasterosteidae, IPungitius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pungitius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 134919;

    /// <inheritdoc />
    public virtual string GenusName => "Pungitius";

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
