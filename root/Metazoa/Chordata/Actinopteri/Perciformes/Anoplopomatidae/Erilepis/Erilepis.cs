using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anoplopomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anoplopomatidae.Erilepis;

/// <summary>
/// Abstract class for Erilepis (genus).
/// NCBI TaxId: 270542
/// </summary>
public abstract class Erilepis : Anoplopomatidae, IErilepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Erilepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 270542;

    /// <inheritdoc />
    public virtual string GenusName => "Erilepis";

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
