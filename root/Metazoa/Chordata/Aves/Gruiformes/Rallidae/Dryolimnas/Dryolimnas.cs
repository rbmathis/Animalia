using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Dryolimnas;

/// <summary>
/// Abstract class for Dryolimnas (genus).
/// NCBI TaxId: 1294517
/// </summary>
public abstract class Dryolimnas : Rallidae, IDryolimnas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dryolimnas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1294517;

    /// <inheritdoc />
    public virtual string GenusName => "Dryolimnas";

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
