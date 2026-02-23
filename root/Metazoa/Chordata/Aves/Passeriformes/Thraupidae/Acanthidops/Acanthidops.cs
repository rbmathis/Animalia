using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Acanthidops;

/// <summary>
/// Abstract class for Acanthidops (genus).
/// NCBI TaxId: 200165
/// </summary>
public abstract class Acanthidops : Thraupidae, IAcanthidops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acanthidops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 200165;

    /// <inheritdoc />
    public virtual string GenusName => "Acanthidops";

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
