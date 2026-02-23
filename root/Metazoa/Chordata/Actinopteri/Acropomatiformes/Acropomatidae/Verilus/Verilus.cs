using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Acropomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Acropomatidae.Verilus;

/// <summary>
/// Abstract class for Verilus (genus).
/// NCBI TaxId: 3051912
/// </summary>
public abstract class Verilus : Acropomatidae, IVerilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Verilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3051912;

    /// <inheritdoc />
    public virtual string GenusName => "Verilus";

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
