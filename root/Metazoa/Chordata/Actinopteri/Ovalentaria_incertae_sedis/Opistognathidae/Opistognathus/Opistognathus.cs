using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Opistognathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Opistognathidae.Opistognathus;

/// <summary>
/// Abstract class for Opistognathus (genus).
/// NCBI TaxId: 270590
/// </summary>
public abstract class Opistognathus : Opistognathidae, IOpistognathus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Opistognathus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 270590;

    /// <inheritdoc />
    public virtual string GenusName => "Opistognathus";

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
