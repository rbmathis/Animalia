using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Pseuderemias;

/// <summary>
/// Abstract class for Pseuderemias (genus).
/// NCBI TaxId: 450849
/// </summary>
public abstract class Pseuderemias : Lacertidae, IPseuderemias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseuderemias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 450849;

    /// <inheritdoc />
    public virtual string GenusName => "Pseuderemias";

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
