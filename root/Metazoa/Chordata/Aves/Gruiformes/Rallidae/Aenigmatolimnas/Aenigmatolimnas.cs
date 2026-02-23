using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Aenigmatolimnas;

/// <summary>
/// Abstract class for Aenigmatolimnas (genus).
/// NCBI TaxId: 2861767
/// </summary>
public abstract class Aenigmatolimnas : Rallidae, IAenigmatolimnas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aenigmatolimnas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2861767;

    /// <inheritdoc />
    public virtual string GenusName => "Aenigmatolimnas";

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
