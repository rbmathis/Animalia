using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Aploactinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Aploactinidae.Aploactisoma;

/// <summary>
/// Abstract class for Aploactisoma (genus).
/// NCBI TaxId: 274719
/// </summary>
public abstract class Aploactisoma : Aploactinidae, IAploactisoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aploactisoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 274719;

    /// <inheritdoc />
    public virtual string GenusName => "Aploactisoma";

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
