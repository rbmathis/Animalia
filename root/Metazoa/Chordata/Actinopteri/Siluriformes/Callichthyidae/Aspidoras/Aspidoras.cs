using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Callichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Callichthyidae.Aspidoras;

/// <summary>
/// Abstract class for Aspidoras (genus).
/// NCBI TaxId: 245755
/// </summary>
public abstract class Aspidoras : Callichthyidae, IAspidoras
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aspidoras";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 245755;

    /// <inheritdoc />
    public virtual string GenusName => "Aspidoras";

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
