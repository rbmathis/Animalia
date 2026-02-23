using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Amaurolimnas;

/// <summary>
/// Abstract class for Amaurolimnas (genus).
/// NCBI TaxId: 1118502
/// </summary>
public abstract class Amaurolimnas : Rallidae, IAmaurolimnas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amaurolimnas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1118502;

    /// <inheritdoc />
    public virtual string GenusName => "Amaurolimnas";

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
