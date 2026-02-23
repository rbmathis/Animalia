using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Euproctus;

/// <summary>
/// Abstract class for Euproctus (genus).
/// NCBI TaxId: 30373
/// </summary>
public abstract class Euproctus : Salamandridae, IEuproctus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Euproctus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30373;

    /// <inheritdoc />
    public virtual string GenusName => "Euproctus";

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
