using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Myrmelastes;

/// <summary>
/// Abstract class for Myrmelastes (genus).
/// NCBI TaxId: 1941453
/// </summary>
public abstract class Myrmelastes : Thamnophilidae, IMyrmelastes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myrmelastes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1941453;

    /// <inheritdoc />
    public virtual string GenusName => "Myrmelastes";

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
