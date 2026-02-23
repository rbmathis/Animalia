using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Formicariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Formicariidae.Cercomacra;

/// <summary>
/// Abstract class for Cercomacra (genus).
/// NCBI TaxId: 183184
/// </summary>
public abstract class Cercomacra : Formicariidae, ICercomacra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cercomacra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 183184;

    /// <inheritdoc />
    public virtual string GenusName => "Cercomacra";

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
