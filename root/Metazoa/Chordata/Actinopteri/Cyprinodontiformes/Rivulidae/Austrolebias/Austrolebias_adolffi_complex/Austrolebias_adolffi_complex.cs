using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Austrolebias;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Austrolebias.Austrolebias_adolffi_complex;

/// <summary>
/// Abstract class for Austrolebias adolffi complex (no rank).
/// NCBI TaxId: 653309
/// </summary>
public abstract class Austrolebias_adolffi_complex : Austrolebias, IAustrolebias_adolffi_complex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Austrolebias adolffi complex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 653309;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Austrolebias_adolffi_complex";
}
