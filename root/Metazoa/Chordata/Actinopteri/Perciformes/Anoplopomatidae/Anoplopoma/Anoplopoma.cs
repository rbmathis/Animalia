using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anoplopomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anoplopomatidae.Anoplopoma;

/// <summary>
/// Abstract class for Anoplopoma (genus).
/// NCBI TaxId: 229289
/// </summary>
public abstract class Anoplopoma : Anoplopomatidae, IAnoplopoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anoplopoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 229289;

    /// <inheritdoc />
    public virtual string GenusName => "Anoplopoma";

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
