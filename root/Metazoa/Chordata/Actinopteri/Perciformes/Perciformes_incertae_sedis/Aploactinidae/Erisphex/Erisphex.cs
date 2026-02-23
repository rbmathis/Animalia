using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Aploactinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Aploactinidae.Erisphex;

/// <summary>
/// Abstract class for Erisphex (genus).
/// NCBI TaxId: 1175604
/// </summary>
public abstract class Erisphex : Aploactinidae, IErisphex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Erisphex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1175604;

    /// <inheritdoc />
    public virtual string GenusName => "Erisphex";

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
