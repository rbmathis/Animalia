using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae.Dinotopterus;

/// <summary>
/// Abstract class for Dinotopterus (genus).
/// NCBI TaxId: 310918
/// </summary>
public abstract class Dinotopterus : Clariidae, IDinotopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dinotopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 310918;

    /// <inheritdoc />
    public virtual string GenusName => "Dinotopterus";

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
