using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scytalinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scytalinidae.Scytalina;

/// <summary>
/// Abstract class for Scytalina (genus).
/// NCBI TaxId: 910304
/// </summary>
public abstract class Scytalina : Scytalinidae, IScytalina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scytalina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 910304;

    /// <inheritdoc />
    public virtual string GenusName => "Scytalina";

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
