using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Reinwardtoena;

/// <summary>
/// Abstract class for Reinwardtoena (genus).
/// NCBI TaxId: 177157
/// </summary>
public abstract class Reinwardtoena : Columbidae, IReinwardtoena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Reinwardtoena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 177157;

    /// <inheritdoc />
    public virtual string GenusName => "Reinwardtoena";

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
