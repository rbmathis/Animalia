using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Anurolimnas;

/// <summary>
/// Abstract class for Anurolimnas (genus).
/// NCBI TaxId: 54494
/// </summary>
public abstract class Anurolimnas : Rallidae, IAnurolimnas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anurolimnas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 54494;

    /// <inheritdoc />
    public virtual string GenusName => "Anurolimnas";

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
